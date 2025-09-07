# Animal_sounds

Aplicație **Console (C#)** care afișează ce sunet face un animal introdus de utilizator.
Dacă animalul nu este în lista cunoscută, programul afișează **"(unknown animal)"**.

## Cum funcționează
1. Afișează animalele cunoscute: `Dog, Cat, Cow, Duck`.
2. Cere utilizatorului să aleagă un animal.
3. Folosește un `switch` pentru a asocia animalul cu sunetul lui.
4. Afișează mesajul

# AnimalSounds.RefactorOOP

Aplicație **Console (C#)** care afișează ce sunet face un animal introdus de utilizator.
Versiune refactorizată OOP: animalele sunt obiecte (`Dog`, `Cat`, `Cow`, `Duck`) care implementează interfața `IAnimal`. Nu folosește pattern-uri avansate; este o structură simplă, clară.

## Ce face
1. Listează animalele cunoscute: `Dog, Cat, Cow, Duck`.
2. Cere utilizatorului un nume de animal.
3. Caută animalul în listă și afișează mesajul.
