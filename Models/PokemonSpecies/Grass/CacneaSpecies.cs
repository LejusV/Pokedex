using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cacnea Species to store common natural stats of all Cacneas
	#region CacneaSpecies
	public class CacneaSpecies : PokemonSpecies
	{
#nullable enable
		private static CacneaSpecies? _instance = null;
#nullable restore
        public static CacneaSpecies Instance => _instance ?? (_instance = new CacneaSpecies());

		#region CacneaSpecies Constructor
		public CacneaSpecies() : base(
			331,
			"Cacnea",
			Grass.Instance,
			0.4,
			51.3,
			new PokemonStats(
				50, // HPs
				85, 40, // Attack & Defense
				85, 40, // Spacial Attack & Defense
				35 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Leer",
				"Disable",
				"Acid",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Absorb",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Cotton-Spore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Spikes",
				"Destiny-Bond",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Nature-Power",
				"Role-Play",
				"Ingrain",
				"Brick-Break",
				"Secret-Power",
				"Teeter-Dance",
				"Needle-Arm",
				"Grass-Whistle",
				"Bullet-Seed",
				"Block",
				"Magical-Leaf",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Switcheroo",
				"Nasty-Plot",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Round",
				"Belch",
				"Rototiller",
				"Fell-Stinger",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}