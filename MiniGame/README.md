```mermaid
classDiagram
    class Program{

    }

    class Player{

    }

    class Sword{

    }

    class Weapon{

    }

    class Gun{

    }

    class Enemy{

    }

    class Character{

    }


    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword

    Program o-- Character    
    Weapon o-- Character
    
    Player --> Gun
    Player --> Sword
    Enemy --> Gun
    Enemy --> Sword



