using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cacturne Species to store common natural stats of all Cacturnes
	#region CacturneSpecies
	public class CacturneSpecies : PokemonSpecies
	{
#nullable enable
		private static CacturneSpecies? _instance = null;
#nullable restore
        public static CacturneSpecies Instance => _instance ?? (_instance = new CacturneSpecies());

		#region CacturneSpecies Constructor
		public CacturneSpecies() : base(
			332,
			"Cacturne",
			Grass.Instance, Dark.Instance,
			1.3,
			77.4,
			new PokemonStats(
				70, // HPs
				115, 60, // Attack & Defense
				115, 60, // Spacial Attack & Defense
				55 // Speed
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
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
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
				"Nature-Power",
				"Role-Play",
				"Ingrain",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Secret-Power",
				"Needle-Arm",
				"Bullet-Seed",
				"Block",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Seed-Bomb",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Confide",
				"Spiky-Shield",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}