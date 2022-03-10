using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sawsbuck Species to store common natural stats of all Sawsbucks
	#region SpeciesSawsbuck
	public class SpeciesSawsbuck : PokemonSpecies
	{
#nullable enable
		private static SpeciesSawsbuck? _instance = null;
#nullable restore
        public static SpeciesSawsbuck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSawsbuck();
                }
                return _instance;
            }
        }

		#region SpeciesSawsbuck Constructor
		public SpeciesSawsbuck() : base(
			"Sawsbuck",
			1.9,
			92.5,
			80, // HPs
			100, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			95		
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
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Jump-Kick",
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Leech-Seed",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
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
				"Megahorn",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Camouflage",
				"Aromatherapy",
				"Bounce",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Horn-Leech",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Sawsbuck PokemonInstance Class
	#region Sawsbuck
	public class SawsbuckInstance : PokemonInstance
	{
		#region Sawsbuck Constructors
		/// <summary>
		/// Sawsbuck Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SawsbuckInstance(string nickname, int level)
		: base(
				586,
				SpeciesSawsbuck.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawsbuck Builder only waiting for a Level
		/// </summary>
		public SawsbuckInstance(int level)
		: base(
				586,
				SpeciesSawsbuck.Instance, // PokemonInstance Species
				"Sawsbuck", level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawsbuck Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sawsbuck() : base(
			586,
			SpeciesSawsbuck.Instance, // PokemonInstance Species
			Normal.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}