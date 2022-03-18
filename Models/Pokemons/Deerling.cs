using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Deerling Species to store common natural stats of all Deerlings
	#region SpeciesDeerling
	public class SpeciesDeerling : PokemonSpecies
	{
#nullable enable
		private static SpeciesDeerling? _instance = null;
#nullable restore
        public static SpeciesDeerling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDeerling();
                }
                return _instance;
            }
        }

		#region SpeciesDeerling Constructor
		public SpeciesDeerling() : base(
			585,
			"Deerling",
			0.6,
			19.5,
			60, // HPs
			60, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75		
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
				"Double-Kick",
				"Jump-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Leech-Seed",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Agility",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Giga-Drain",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Camouflage",
				"Aromatherapy",
				"Fake-Tears",
				"Odor-Sleuth",
				"Grass-Whistle",
				"Bounce",
				"Natural-Gift",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Deerling PokemonInstance Class
	#region Deerling
	public class DeerlingInstance : PokemonInstance
	{
		#region Deerling Constructors
		/// <summary>
		/// Deerling Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DeerlingInstance(string nickname, int level)
		: base(
				SpeciesDeerling.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deerling Builder only waiting for a Level
		/// </summary>
		public DeerlingInstance(int level)
		: base(
				SpeciesDeerling.Instance, // PokemonInstance Species
				"Deerling", level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deerling Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DeerlingInstance() : base(
			SpeciesDeerling.Instance, // PokemonInstance Species
			Normal.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}