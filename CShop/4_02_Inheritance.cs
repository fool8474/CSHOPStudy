using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Notebook : Computer
{
    bool fingerScan;
    public bool HasFingerScanDevice()
    {
        return fingerScan;
    }

    public void CloseLid()
    {
        Shutdown();
    }
}

public class Desktop : Computer
{
}

public class Netbook : Computer
{ 
}

public class Computer
{
    protected bool powerOn;
    public void Boot()
    {
        Console.WriteLine("컴퓨터를 부팅합니다.");
    }
    public void Shutdown()
    {
        Console.WriteLine("컴퓨터를 종료합니다.");
    }
    public void Reset()
    {
        Console.WriteLine("컴퓨터를 재시작합니다.");
    }
}

sealed class Pen
{ }

// public class EletricPen : Pen { }  // 상속이 되지 않는다. (sealed)
// C#은 다중상속은 허용하지 않음.


public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}

namespace CShop
{
    class _4_02_Inheritance
    {
        public _4_02_Inheritance()
        {
            Notebook notebook = new Notebook();
            notebook.Boot();
            notebook.CloseLid();

            Computer pc1 = notebook; // 암시적 형변환
            pc1.Boot();
            pc1.Shutdown();
            // 부모 클래스인 Computer가 자식 클래스가 되는 것은 가능하나
            // 자식 클래스가 부모 클래스로 되는 것은 불가능하다.

            Desktop desktop = new Desktop();
            Netbook netbook = new Netbook();

            DeviceManager deviceManager = new DeviceManager();
            deviceManager.TurnOff(desktop);
            deviceManager.TurnOff(netbook);
            deviceManager.TurnOff(notebook);

            Computer[] machines = new Computer[] {new Notebook(), new Desktop(), new Netbook() };

            foreach(Computer device in machines)
            {
                deviceManager.TurnOff(device);
            }
        }
    }
}
