new Point(2, 3);
var point3d = new Point3D(2, 3, 4);

record Point(double X, double Y);

record Point3D(double X, double Y, double Z) : Point(X, Y);