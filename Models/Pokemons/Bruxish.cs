using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bruxish Species to store common natural stats of all Bruxishs
	#region SpeciesBruxish
	public class SpeciesBruxish : PokemonSpecies
	{
#nullable enable
		private static SpeciesBruxish? _instance = null;
#nullable restore
        public static SpeciesBruxish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBruxish();
                }
                return _instance;
            }
        }

		#region SpeciesBruxish Constructor
		public SpeciesBruxish() : base(
			779,
			"Bruxish",
			0.9,
			19.0,
			68, // HPs
			105, 70, // Attack & Defense
			70, 70, // Special Attack & Defense
			92		
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
				"Bite",
				"Disable",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Dream-Eater",
				"Psywave",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Torment",
				"Facade",
				"Taunt",
				"Poison-Fang",
				"Astonish",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Water-Pulse",
				"Payback",
				"Embargo",
				"Fling",
				"Aqua-Tail",
				"Giga-Impact",
				"Ice-Fang",
				"Trick-Room",
				"Aqua-Jet",
				"Venoshock",
				"Synchronoise",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion

	//Bruxish PokemonInstance Class
	#region Bruxish
	public class BruxishInstance : PokemonInstance
	{
		#region Bruxish Constructors
		/// <summary>
		/// Bruxish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BruxishInstance(string nickname, int level)
		: base(
				SpeciesBruxish.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bruxish Builder only waiting for a Level
		/// </summary>
		public BruxishInstance(int level)
		: base(
				SpeciesBruxish.Instance, // PokemonInstance Species
				"Bruxish", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bruxish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BruxishInstance() : base(
			SpeciesBruxish.Instance, // PokemonInstance Species
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}