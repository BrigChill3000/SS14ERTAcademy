using Robust.Shared.Serialization;

namespace Content.Shared._Sunrise.Weapons.Ranged;

[Serializable, NetSerializable]
public enum EnergyGunFireModeVisuals : byte
{
    State
}

[Serializable, NetSerializable]
public enum EnergyGunFireModeState : byte
{
    Disabler,
    Lethal,
    Special
}
