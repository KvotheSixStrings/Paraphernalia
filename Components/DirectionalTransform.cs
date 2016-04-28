using UnityEngine;
using System.Collections;

public class DirectionalTransform : DirectionalComponent {

	public Vector3 leftPosition;
    public Vector3 leftScale = Vector3.one;
    public Vector3 rightPosition;
    public Vector3 rightScale = Vector3.one;
    public Vector3 upPosition;
    public Vector3 upScale = Vector3.one;
    public Vector3 downPosition;
    public Vector3 downScale = Vector3.one;

	protected override void SetLeft () {
		transform.localPosition = leftPosition;
        transform.localScale = leftScale;
	}

	protected override void SetRight () {
		transform.localPosition = rightPosition;
        transform.localScale = rightScale;
	}

	protected override void SetUp () {
		transform.localPosition = upPosition;
        transform.localScale = upScale;
	}

	protected override void SetDown () {
		transform.localPosition = downPosition;
        transform.localScale = downScale;
	}

	void OnDrawGizmos () {
		Gizmos.matrix = transform.parent.localToWorldMatrix;
		Gizmos.color = Color.red;
		Gizmos.DrawLine(leftPosition, rightPosition);
		Gizmos.color = Color.green;
		Gizmos.DrawLine(downPosition, upPosition);
	}
}
