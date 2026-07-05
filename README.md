# [ENG] Triki Control
<img src="img/Triki00.jpg" width="400">

A lightweight Windows tray application that turns the **Triki BLE controller** (created by **Żabka** and **HopX**) into a customizable desktop remote.

The application connects to a Triki device via Bluetooth Low Energy (BLE), interprets motion and rotation gestures, and maps them to Windows actions such as volume control, media playback, and application launching.

## Features

* Bluetooth LE connectivity with Triki devices
* Runs in the Windows system tray
* Automatic reconnection support
* Battery level monitoring
* Customizable gesture-to-action mappings
* JSON-based settings storage
* Media playback controls
* Rotary volume control
* Application launcher actions
* Simple Windows Forms configuration UI

## Supported Gestures

* Right rotation
* Left rotation
* Shake
* Face down
* Click (currently unavailable)

## Supported Actions

* Volume Up / Down
* Mute
* Play / Pause
* Next / Previous Track
* Launch Application
* Up Arrow
* Down Arrow
* Left Arrow
* Right Arror

## Technology

* .NET 8
* Windows Forms
* Windows Bluetooth LE APIs
* NAudio

## How to run

* Download the ZIP package (Code > Download ZIP)
* Unzip anywhere
* Go to the TrikiControl folder and run TrikiControlApp or START.bat
* The program will automatically minimize to the tray. To set your own keys, click the bottle cap icon.
* If the program doesn't start, go to the install_env folder and run install_env.bat and try running START.bat again

## About Triki
<img src="img/Triki01.jpg" width="400">

Triki is a Bluetooth LE motion controller developed by Żabka and HopX. Originally designed for interaction with mobile applications, this project extends its functionality and allows it to be used as a practical desktop controller for Windows.

## License

MIT License
<br><br><br><br><br><br><br>



# [PL] Triki Control
<img src="img/Triki00.jpg" width="400">

Lekka aplikacja dla systemu Windows działająca w zasobniku systemowym, która zamienia kontroler **Triki BLE** (stworzony przez **Żabkę** i **HopX**) w konfigurowalny pilot do komputera.

Aplikacja łączy się z urządzeniem Triki przez Bluetooth Low Energy (BLE), interpretuje gesty ruchowe i obrotowe, a następnie mapuje je na akcje systemowe, takie jak sterowanie głośnością, multimediami czy uruchamianie aplikacji.

## Funkcje

* Obsługa urządzeń Triki przez Bluetooth LE
* Działanie w zasobniku systemowym Windows
* Automatyczne ponowne łączenie
* Monitorowanie poziomu baterii
* Konfigurowalne mapowanie gestów na akcje
* Zapisywanie ustawień w pliku JSON
* Sterowanie multimediami
* Regulacja głośności za pomocą gestów obrotowych
* Uruchamianie aplikacji
* Prosty interfejs konfiguracyjny Windows Forms

## Obsługiwane gesty

* Obrót zgodnie z ruchem wskazówek zegara
* Obrót przeciwnie do ruchu wskazówek zegara
* Potrząśnięcie
* Odwrócenie urządzenia ekranem do dołu
* Kliknięcie (obecnie niedostepne)

## Obsługiwane akcje

* Głośniej / Ciszej
* Wyciszenie
* Odtwarzanie / Pauza
* Następny / Poprzedni utwór
* Uruchomienie aplikacji
* Strzałka w góre
* Strzałka w dół
* Strzałka w lewo
* Strzałka w prawo

## Technologie

* .NET 8
* Windows Forms
* Windows Bluetooth LE API
* NAudio

## Jak uruchomić

* Pobierz paczkę ZIP (Code > Download ZIP)
* Rozpakuj gdziekolwiek
* Wejdz do folderu TrikiControl i uruchom TrikiControlApp lub START.bat
* Program automatycznie zminimalizuje się do tray, aby ustawić własne klawisze kliknij ikonę kapsla.
* Gdy program się nie uruchomi wejdz do folderu install_env i uruchom install_env.bat i spróbuj ponownie uruchomić START.bat

## O Triki
<img src="img/Triki01.jpg" width="400">

Triki to kontroler Bluetooth LE opracowany przez Żabkę i HopX. Pierwotnie został zaprojektowany do współpracy z aplikacjami mobilnymi, a ten projekt rozszerza jego możliwości, pozwalając wykorzystać go jako praktyczny kontroler do komputera z systemem Windows.

## Licencja

MIT License
