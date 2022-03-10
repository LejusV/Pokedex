using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cinccino Species to store common natural stats of all Cinccinos
	#region SpeciesCinccino
	public class SpeciesCinccino : PokemonSpecies
	{
#nullable enable
		private static SpeciesCinccino? _instance = null;
#nullable restore
        public static SpeciesCinccino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCinccino();
                }
                return _instance;
            }
        }

		#region SpeciesCinccino Constructor
		public SpeciesCinccino() : base(
			"Cinccino",
			0.5,
			7.5,
			75, // HPs
			95, 60, // Attack & Defense
			65, 60, // Special Attack & Defense
			115		
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
				"Sing",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Tickle",
				"Bullet-Seed",
				"Covet",
				"Calm-Mind",
				"Rock-Blast",
				"Shock-Wave",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Gunk-Shot",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Tail-Slap",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Cinccino PokemonInstance Class
	#region Cinccino
	public class CinccinoInstance : PokemonInstance
	{
		#region Cinccino Constructors
		/// <summary>
		/// Cinccino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CinccinoInstance(string nickname, int level)
		: base(
				573,
				SpeciesCinccino.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinccino Builder only waiting for a Level
		/// </summary>
		public CinccinoInstance(int level)
		: base(
				573,
				SpeciesCinccino.Instance, // PokemonInstance Species
				"Cinccino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinccino Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cinccino() : base(
			573,
			SpeciesCinccino.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}