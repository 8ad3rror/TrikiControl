using TrikiControl.Models;

namespace TrikiControl.Gestures;

public sealed class GestureDetector
{
    private readonly ImuOrientationFilter _orientationFilter = new();

    private GestureType? _currentGesture;
    private DateTimeOffset _gestureStartedAt = DateTimeOffset.MinValue;
    private DateTimeOffset _lastEmittedAt = DateTimeOffset.MinValue;

    private readonly TimeSpan _holdRequired = TimeSpan.FromMilliseconds(10);
    private readonly TimeSpan _repeatInterval = TimeSpan.FromMilliseconds(80);

    public GestureEvent? Process(ImuSample sample)
    {
        var orientation = _orientationFilter.Update(sample);
        var detected = Detect(sample, orientation);

        if (detected is null)
        {
            _currentGesture = null;
            return null;
        }

        var detectedType = detected.Value.Type;

        if (_currentGesture != detectedType)
        {
            _currentGesture = detectedType;
            _gestureStartedAt = sample.TimestampUtc;
            _lastEmittedAt = DateTimeOffset.MinValue;
            return null;
        }

        if (sample.TimestampUtc - _gestureStartedAt < _holdRequired)
            return null;

        if (sample.TimestampUtc - _lastEmittedAt < _repeatInterval)
            return null;

        _lastEmittedAt = sample.TimestampUtc;
        return detected.Value;
    }

    public void Reset()
    {
        _orientationFilter.Reset();
        _currentGesture = null;
        _gestureStartedAt = DateTimeOffset.MinValue;
        _lastEmittedAt = DateTimeOffset.MinValue;
    }

    private static GestureEvent? Detect(ImuSample sample, ImuOrientation orientation)
    {
        const double rotationThreshold = 25;

        if (sample.GyroZ > rotationThreshold)
        {
            return new GestureEvent(
                GestureType.RotateClockwise,
                sample.TimestampUtc,
                sample.GyroZ);
        }

        if (sample.GyroZ < -rotationThreshold)
        {
            return new GestureEvent(
                GestureType.RotateCounterClockwise,
                sample.TimestampUtc,
                sample.GyroZ);
        }

        var gyroMagnitude =
            Math.Abs(sample.GyroX) +
            Math.Abs(sample.GyroY);
            //Math.Abs(sample.GyroZ);

        if (gyroMagnitude > 60)
        {
       
            return new GestureEvent(
                GestureType.Shake,
                sample.TimestampUtc,
                gyroMagnitude);
        }
/*
        if (Math.Abs(orientation.Pitch) > 130)
        {
            return new GestureEvent(
                GestureType.FaceUp,
                sample.TimestampUtc,
                orientation.Pitch);
        }

        if (sample.GyroY == -90)
        {
            return new GestureEvent(
                GestureType.FaceDown,
                sample.TimestampUtc,
                sample.GyroX);
        }
*/
        return null;
    }
}