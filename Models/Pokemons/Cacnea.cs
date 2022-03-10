using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cacnea Species to store common natural stats of all Cacneas
	#region SpeciesCacnea
	public class SpeciesCacnea : PokemonSpecies
	{
#nullable enable
		private static SpeciesCacnea? _instance = null;
#nullable restore
        public static SpeciesCacnea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCacnea();
                }
                return _instance;
            }
        }

		#region SpeciesCacnea Constructor
		public SpeciesCacnea() : base(
			"Cacnea",
			0.4,
			51.3,
			50, // HPs
			85, 40, // Attack & Defense
			85, 40, // Special Attack & Defense
			35		
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

	//Cacnea PokemonInstance Class
	#region Cacnea
	public class CacneaInstance : PokemonInstance
	{
		#region Cacnea Constructors
		/// <summary>
		/// Cacnea Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CacneaInstance(string nickname, int level)
		: base(
				331,
				SpeciesCacnea.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacnea Builder only waiting for a Level
		/// </summary>
		public CacneaInstance(int level)
		: base(
				331,
				SpeciesCacnea.Instance, // PokemonInstance Species
				"Cacnea", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacnea Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cacnea() : base(
			331,
			SpeciesCacnea.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}