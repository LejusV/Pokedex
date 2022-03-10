using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Crustle Species to store common natural stats of all Crustles
	#region SpeciesCrustle
	public class SpeciesCrustle : PokemonSpecies
	{
#nullable enable
		private static SpeciesCrustle? _instance = null;
#nullable restore
        public static SpeciesCrustle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCrustle();
                }
                return _instance;
            }
        }

		#region SpeciesCrustle Constructor
		public SpeciesCrustle() : base(
			"Crustle",
			1.4,
			200.0,
			70, // HPs
			105, 125, // Attack & Defense
			65, 75, // Special Attack & Defense
			45		
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
				"Sand-Attack",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Wrecker",
				"Stone-Edge",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Shell-Smash",
				"Struggle-Bug",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Crustle PokemonInstance Class
	#region Crustle
	public class CrustleInstance : PokemonInstance
	{
		#region Crustle Constructors
		/// <summary>
		/// Crustle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CrustleInstance(string nickname, int level)
		: base(
				558,
				SpeciesCrustle.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crustle Builder only waiting for a Level
		/// </summary>
		public CrustleInstance(int level)
		: base(
				558,
				SpeciesCrustle.Instance, // PokemonInstance Species
				"Crustle", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crustle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Crustle() : base(
			558,
			SpeciesCrustle.Instance, // PokemonInstance Species
			Bug.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}