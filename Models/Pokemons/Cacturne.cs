using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cacturne Species to store common natural stats of all Cacturnes
	#region SpeciesCacturne
	public class SpeciesCacturne : PokemonSpecies
	{
#nullable enable
		private static SpeciesCacturne? _instance = null;
#nullable restore
        public static SpeciesCacturne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCacturne();
                }
                return _instance;
            }
        }

		#region SpeciesCacturne Constructor
		public SpeciesCacturne() : base(
			332,
			"Cacturne",
			1.3,
			77.4,
			70, // HPs
			115, 60, // Attack & Defense
			115, 60, // Special Attack & Defense
			55		
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

	//Cacturne PokemonInstance Class
	#region Cacturne
	public class CacturneInstance : PokemonInstance
	{
		#region Cacturne Constructors
		/// <summary>
		/// Cacturne Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CacturneInstance(string nickname, int level)
		: base(
				SpeciesCacturne.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacturne Builder only waiting for a Level
		/// </summary>
		public CacturneInstance(int level)
		: base(
				SpeciesCacturne.Instance, // PokemonInstance Species
				"Cacturne", level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacturne Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CacturneInstance() : base(
			SpeciesCacturne.Instance, // PokemonInstance Species
			Grass.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}