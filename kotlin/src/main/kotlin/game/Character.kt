package game

open class Character constructor(
    armorClass: Int,
    weaponDamage: Int,
    race: String,
    force: Int
) {
    internal val armorClass: Int = armorClass
    internal val damageDealt: Int = weaponDamage

    var race: String = race
        internal set
    internal var force: Int = force
}