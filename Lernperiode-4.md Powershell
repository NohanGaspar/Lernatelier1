[bool]$App2 = $true;

try {

    while ($App2) {
        Clear-Host
        Write-Host "Bitte wählen Sie eine Option:"
        Write-Host "Option 1: alle Prozesse anzeigen"
        Write-Host "Option 2: Ausgabe von allen Services"
        Write-Host "Option 3: Ausgabe von Netzadapter"
        Write-Host "Option 4: Beenden"
        $choice1 = Read-Host "Geben Sie Ihre Wahl ein (1-4)"

        if ($choice1 -eq "1") {
            Get-Process
            $choice2 = Read-Host "Wollen sie noch einmal wählen oder beenden? (w: wiederholen, b: beenden)"
            
            if ($choice2 -eq "w") {
                continue 
            }

            elseif ($choice2 -eq "b") {
                $App2 = $false
            }

            else {
                Write-Host "Ungültige Eingabe. Bitte wählen Sie 'w' oder 'b'."
            }
        }

        elseif ($choice1 -eq "2") {
            Get-Service
            $choice3 = Read-Host "Wollen sie noch einmal wählen oder beenden? (w: wiederholen, b: beenden)"

            if ($choice3 -eq "w") {
                continue 
            }

            elseif ($choice3 -eq "b") {
                $App2 = $false
            }

            else {
                Write-Host "Ungültige Eingabe. Bitte wählen Sie 'w' oder 'b'."
            }
        }

        elseif ($choice1 -eq "3") {
            Get-NetAdapter
            $choice4 = Read-Host "Wollen sie noch einmal wählen oder beenden? (w: wiederholen, b: beenden)"

            if ($choice4 -eq "w") {
                continue 
            }

            elseif ($choice4 -eq "b") {
                $App2 = $false
            }

            else {
                Write-Host "Ungültige Eingabe. Bitte wählen Sie 'w' oder 'b'."
            }
        }

        elseif ($choice1 -eq "4") {
            $App2 = $false
        }

        else {
            Write-Host "Ungültige Eingabe"
        }
    }
}
catch {
    Write-Host "Ein Fehler ist aufgetreten."
}
