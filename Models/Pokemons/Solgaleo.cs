using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Solgaleo Species to store common natural stats of all Solgaleos
	#region SpeciesSolgaleo
	public class SpeciesSolgaleo : PokemonSpecies
	{
#nullable enable
		private static SpeciesSolgaleo? _instance = null;
#nullable restore
        public static SpeciesSolgaleo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSolgaleo();
                }
                return _instance;
            }
        }

		#region SpeciesSolgaleo Constructor
		public SpeciesSolgaleo() : base(
			791,
			"Solgaleo",
			3.4,
			230.0,
			137, // HPs
			137, 107, // Attack & Defense
			113, 89, // Special Attack & Defense
			97		
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
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Teleport",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Metal-Claw",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Facade",
				"Rock-Tomb",
				"Metal-Sound",
				"Cosmic-Power",
				"Calm-Mind",
				"Wake-Up-Slap",
				"Gyro-Ball",
				"Metal-Burst",
				"Flare-Blitz",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Wide-Guard",
				"Psyshock",
				"Flame-Charge",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Noble-Roar",
				"Confide",
				"Sunsteel-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Solgaleo PokemonInstance Class
	#region Solgaleo
	public class SolgaleoInstance : PokemonInstance
	{
		#region Solgaleo Constructors
		/// <summary>
		/// Solgaleo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SolgaleoInstance(string nickname, int level)
		: base(
				SpeciesSolgaleo.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solgaleo Builder only waiting for a Level
		/// </summary>
		public SolgaleoInstance(int level)
		: base(
				SpeciesSolgaleo.Instance, // PokemonInstance Species
				"Solgaleo", level,
				Psychic.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Solgaleo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SolgaleoInstance() : base(
			SpeciesSolgaleo.Instance, // PokemonInstance Species
			Psychic.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}