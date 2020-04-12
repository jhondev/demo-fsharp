type Disk =
    | HardDisk of RPM: int * Platters: int
    | SolidState
    | MMC of NumberOfPins: int

let myHardDisk = HardDisk(RPM = 250, Platters = 7)
let myHardDiskShort = HardDisk(250, 7)
let args = 250, 7
let myHardDiskTupled = HardDisk args
let myMMC = MMC 5
let mySSD = SolidState

let seek disk =
    match disk with
    | HardDisk _ -> "Seeking loudly at a reasonable speed!"
    | SolidState -> "Seeking quietly but slowly"
    | MMC _ -> "Already found it!"
    
seek mySSD
