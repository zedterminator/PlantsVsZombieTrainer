# PlantsVsZombieTrainer
Anh em chọn màu ở đây: https://flatuicolors.com/

## Kéo thả title:
```C#
private bool dragging = false;
private Point startPoint = new Point(0, 0);
private void panelTop_MouseDown(object sender, MouseEventArgs e)
{
    dragging = true;
    startPoint = new Point(e.X, e.Y);
}

private void panelTop_MouseUp(object sender, MouseEventArgs e)
{
    dragging = false;
}

private void panelTop_MouseMove(object sender, MouseEventArgs e)
{
    if (dragging)
    {
        Point p = PointToScreen(e.Location);
        Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
    }
}
```
## Ghi một dãy bytes:
```C#
mem.WriteMemory("base+684E4", "bytes", "0F 85 98 FE FF FF");
```

## Ghi pointer và offsets:
```C#
mem.WriteMemory("base+00329670,320,18,0,8,5578", "int", sun.ToString());
```
