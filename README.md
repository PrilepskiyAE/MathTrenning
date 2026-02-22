Mathf
---

Abs, Clamp, Round
Mathf Documentation:
https://docs.unity3d.com/ScriptReference/Mathf.html

```csharp
float horizontal = Input.GetAxis("Horizontal");
GetComponent<Rigidbody>().velocity = new Vector3(horizontal * 3f, 0f, 0f);
StepAudio.volume = Mathf.Abs(horizontal);

transform.position = new Vector3(Mathf.Ceil(Target.position.x), Mathf.Ceil(Target.position.y), Mathf.Ceil(Target.position.z))

transform.position = new Vector3(
    Mathf.Clamp(Target.position.x, -1f, 1f),
    Mathf.Clamp(Target.position.y, -1f, 1f), 
    Mathf.Clamp(Target.position.z, -1f, 1f)
    );
```

---


Sin, Cos


```csharp
void Update()

{

    transform.localPosition = new Vector3(0f, Mathf.Sin(Time.time), 0f);

}

public float Frequency;
public float Amplitude;
private Vector3 _startScale;

void Update()

{

    transform.localScale = _startScale * (Mathf.Sin(Time.time * Frequency * 2 * Mathf.PI) * Amplitude + 1f);

}
```
http://matematikam.ru/calculate-online/grafik.php

---

Mathf.Lerp
```csharp
public float MinValue;
public float MaxValue;
[Range(0f, 1f)] public float Value;

…

float angle = Mathf.Lerp(MaxValue, MaxValue, Value);
transform.localEulerAngles = new Vector3(0f, 0f, angle);



public Transform Target;
public float LerpRate;

…

transform.position = Vector3.Lerp(transform.position, Target.position, Time.deltaTime * LerpRate);

transform.localScale = Vector3.Lerp(transform.localScale, Target.localScale, Time.deltaTime * LerpRate);

transform.rotation = Quaternion.Lerp(transform.rotation, Target.rotation, Time.deltaTime * LerpRate);
```
---

Mathf.MoveTowards
```csharp
public float RotationSpeed;
public float TargetY;
private float _yAngle;

…

_yAngle = Mathf.MoveTowards(_yAngle, TargetY, RotationSpeed);
transform.eulerAngles = new Vector3(0f,_yAngle,0f);
```

---
PerlinNoise
```csharp
float y = Mathf.PerlinNoise(transform.position.x * Time.time, transform.position.y * Time.time);

transform.position = new Vector3(transform.position.x, y, transform.position.z);
```
---

