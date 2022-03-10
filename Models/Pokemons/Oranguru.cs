using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Oranguru Species to store common natural stats of all Orangurus
	#region SpeciesOranguru
	public class SpeciesOranguru : PokemonSpecies
	{
#nullable enable
		private static SpeciesOranguru? _instance = null;
#nullable restore
        public static SpeciesOranguru Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOranguru();
                }
                return _instance;
            }
        }

		#region SpeciesOranguru Constructor
		public SpeciesOranguru() : base(
			"Oranguru",
			1.5,
			76.0,
			90, // HPs
			60, 80, // Attack & Defense
			90, 110, // Special Attack & Defense
			60		
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
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Feint-Attack",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Brick-Break",
				"Extrasensory",
				"Calm-Mind",
				"Payback",
				"Embargo",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Foul-Play",
				"After-You",
				"Round",
				"Stored-Power",
				"Quash",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Psychic-Terrain",
				"Instruct",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Oranguru PokemonInstance Class
	#region Oranguru
	public class OranguruInstance : PokemonInstance
	{
		#region Oranguru Constructors
		/// <summary>
		/// Oranguru Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OranguruInstance(string nickname, int level)
		: base(
				765,
				SpeciesOranguru.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oranguru Builder only waiting for a Level
		/// </summary>
		public OranguruInstance(int level)
		: base(
				765,
				SpeciesOranguru.Instance, // PokemonInstance Species
				"Oranguru", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oranguru Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Oranguru() : base(
			765,
			SpeciesOranguru.Instance, // PokemonInstance Species
			Normal.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}