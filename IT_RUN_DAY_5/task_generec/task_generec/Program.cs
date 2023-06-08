using task_generec;

Menu Napitki = new Menu();
Napitki.MenuName = "napitki";

Menu Chay = new Menu();
Chay.MenuName = "chay";

Menu sok = new Menu();
sok.MenuName = "sok";

Napitki.Childs = new Menu[2];
Napitki.Childs[0] = Chay;
Napitki.Childs[1] = sok;

MenuGenerator.GenerateMenu(Napitki);

