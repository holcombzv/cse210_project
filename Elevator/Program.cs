Elevator elevator1 = new Elevator(1, 30);
Console.WriteLine(elevator1.listFloors());
Console.WriteLine(elevator1.displayFloor());
elevator1.changeFloor(29);
Console.WriteLine(elevator1.listFloors());
Console.WriteLine(elevator1.displayFloor());

Vip vipElevator = new Vip(1, 31, "1234");
string entered = Console.ReadLine()!;
if(vipElevator.enterPassword(entered)) {
    vipElevator.changeFloor(31);
    Console.WriteLine(vipElevator.listFloors());
    Console.WriteLine(vipElevator.displayFloor());
}