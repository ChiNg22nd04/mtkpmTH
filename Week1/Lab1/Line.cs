class Line {
	private Point2D p1, p2;
	public Line(Point2D p1, Point2D p2) {
		this.p1 = p1;
		this.p2 = p2;
	}
	public double Magnitude() => Point2D.Distance(p1, p2);
	public Point2D Center() => new Point2D((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);
}