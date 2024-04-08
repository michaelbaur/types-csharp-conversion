namespace ECMAScript.Stubs;

public abstract class Union<T1, T2>
{
    public static implicit operator Union<T1, T2>(T1 o) => null!;
    public static implicit operator Union<T1, T2>(T2 o) => null!;
    public static explicit operator T1(Union<T1, T2> u) => default!;
    public static explicit operator T2(Union<T1, T2> u) => default!;
}

public abstract class Union<T1, T2, T3>
{
    public static implicit operator Union<T1, T2, T3>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3> u) => default!;
}

public abstract class Union<T1, T2, T3, T4>
{
    public static implicit operator Union<T1, T2, T3, T4>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4> u) => default!;
}

public abstract class Union<T1, T2, T3, T4, T5>
{
    public static implicit operator Union<T1, T2, T3, T4, T5>(T5 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T4 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T3 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T2 o) => null!;
    public static implicit operator Union<T1, T2, T3, T4, T5>(T1 o) => null!;
    public static explicit operator T1(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T2(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T3(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T4(Union<T1, T2, T3, T4, T5> u) => default!;
    public static explicit operator T5(Union<T1, T2, T3, T4, T5> u) => default!;
}

