#Region "To-Do List Region"
'Find a better way to get random index of 2 arrays
'Find a better way to get random index everytime the button on the form is pressed
'Create Preset Loadout function
'Find out if you could use a single random rather than having multiple randoms.
'Find a safegaurd for weapons to check if they got the same index and if they did reroll it.
#End Region

Public Class cold_war

#Region "Variables Region"
    Dim challengeName As String
    Dim index As Integer
    Dim challengeDesc As String
#End Region

#Region "Arrays Region"

#Region "Challenges"

    ReadOnly cName() As String = {
            "1 room",
            "First Weapon",
            "Perk Maintenance",
            "One by One",
            "3-2-1",
            "Powerless Lifetime",
            "No More Use",
            "Wall Buyer",
            "Juggernaut",
            "Equipment Malfunction",
            "Hot Potato",
            "Radio Out"
            }

    ReadOnly cDesc() As String = {
            "Can't Kill Zombies Outside of Spawn or Stay Only In Spawn",
            "Must Use The First Weapon You Get From The Mystery Box For The Whole Game",
            "Can Only Get Perks From Trials",
            "Only 1 Person Can Leave Spawn At A Time",
            "3 Perks, 2 Box Spins, 1 PaP",
            "No Power",
            "When Weapon Is Out Of Ammo Buy A New Gun",
            "Only Wall Weapons Are Allowed(Knife Must Be Set In Class)",
            "Can Only Buy Juggernaut & Use LMGs in Hipefire(Armor Allowed)",
            "No Lethal Or Equipment Allowed",
            "Buy A New Gun Every Round",
            "No Supports Allowed / No Talking"
            }

#End Region
#Region "Loadouts"

    Dim wClass() As String = {
        "Assualt Rifles",
        "Submachine Guns",
        "Tactical Rifles",
        "Light Machineguns",
        "Sniper Rifles",
        "Pistols",
        "Shotguns",
        "Launchers",
        "Specials"
        }

    Dim AR() As String = {
        "XM4",
        "AK-47",
        "KRIG 6",
        "QBZ-83",
        "FFAR",
        "GROZA"
    }

    Dim SMG() As String = {
        "MP5",
        "Milano 821",
        "AK-74u",
        "KSP 45",
        "Bullfrog",
        "Mac-10"
    }

    Dim Tac() As String = {
        "Type 63",
        "M16",
        "AUG",
        "DMR 14"
    }

    Dim LMG() As String = {
    "Stoner 63",
    "RPD",
    "M60"
    }

    Dim Snipe() As String = {
        "Pelington 703",
        "LW3 - Tundra",
        "M82"
    }

    Dim Pist() As String = {
        "1911",
        "Magnum",
        "Diamatti"
    }

    Dim Shot() As String = {
        "Hauer 77",
        "Gallo SA12",
        "Streetsweeper"
    }

    Dim Launch() As String = {
        "Cigma 2",
        "RPG-7"
    }

    Dim Specialz() As String = {
        "Knife",
        "M79",
        "Sledgehammer"
    }

    Dim Presets() As String = {
        "Run & Gun",
        "Jugger",
        "Social Distance",
        "America",
        "Old Skool",
        "Skadoosh",
        "Perserverance"
    }

    Dim Fields() As String = {
        "Frost Blast",
        "Energy Mine",
        "Healing Aura",
        "Aether Shroud",
        "Ring of Fire"
    }

    Dim Perks() As String = {
        "Jugger-Nog",
        "Speed Cola",
        "Quick Revive",
        "Stamin-Up",
        "Elemental Pop",
        "Deadshot Daiquiri"
    }

    Dim Mods() As String = {
        "Napalm Blast",
        "Cryofreeze",
        "Brain Rot",
        "None"
    }

#End Region

#End Region
#Region "Functions Region"

    'Returns the challenge and it's description
    Public Function challenge() As Tuple(Of String, String)
        Dim ran As New Random
        index = ran.Next(0, cName.Length - 1)
        challengeName = cName(index)
        challengeDesc = cDesc(index)

        Return Tuple.Create(challengeName, challengeDesc)
    End Function

    'Creates Loadout Set
    Public Sub loadout()

        Dim wcRan As New Random
        Dim cpRan As New Random
        Dim wep As New Random
        Dim f As New Random
        Dim a As New Random
        Dim i As Integer
        Dim am As Integer
        Dim weaponClass As String
        Dim weapon As String
        Dim field As String
        Dim amod As String

        'Determines what weapon is selected
        index = wcRan.Next(0, wClass.Length - 1)
        weaponClass = wClass(index)
        Select Case weaponClass
            Case "Assualt Rifles"
                'Random Assualt Rifle
                index = wep.Next(0, AR.Length - 1)
                weapon = AR(index)

            Case "Submachine Guns"
                'Random SMG
                index = wep.Next(0, SMG.Length - 1)
                weapon = SMG(index)

            Case "Tactical Rifles"
                'Random Tact Rifles
                index = wep.Next(0, Tac.Length - 1)
                weapon = Tac(index)

            Case "Light Machineguns"
                'Random LMGs
                index = wep.Next(0, LMG.Length - 1)
                weapon = LMG(index)

            Case "Sniper Rifles"
                'Random Snipers
                index = wep.Next(0, Snipe.Length - 1)
                weapon = Snipe(index)

            Case "Pistols"
                'Random Pistol
                index = wep.Next(0, Pist.Length - 1)
                weapon = Pist(index)

            Case "Shotguns"
                'Ranom Shotty
                index = wep.Next(0, Shot.Length - 1)
                weapon = Shot(index)

            Case "Launchers"
                'Random Launcher
                index = wep.Next(0, Launch.Length - 1)
                weapon = Launch(index)

            Case "Specials"
                'Random Special
                index = wep.Next(0, Specialz.Length - 1)
                weapon = Specialz(index)

        End Select

        'Determine what field upgrade is selected
        i = f.Next(0, Fields.Length - 1)
        field = Fields(i)

        'Determine Ammo mod used
        am = a.Next(0, Mods.Length - 1)
        amod = Mods(am)

        Main.txtWeapon.Text = weapon
        Main.txtField.Text = field
        Main.txtAmmo.Text = amod
    End Sub

#End Region


End Class