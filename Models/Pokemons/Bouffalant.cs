using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bouffalant Species to store common natural stats of all Bouffalants
	#region SpeciesBouffalant
	public class SpeciesBouffalant : PokemonSpecies
	{
#nullable enable
		private static SpeciesBouffalant? _instance = null;
#nullable restore
        public static SpeciesBouffalant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBouffalant();
                }
                return _instance;
            }
        }

		#region SpeciesBouffalant Constructor
		public SpeciesBouffalant() : base(
			"Bouffalant",
			1.6,
			94.6,
			95, // HPs
			110, 95, // Attack & Defense
			40, 95, // Special Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Thrash",
				"Leer",
				"Surf",
				"Strength",
				"Earthquake",
				"Toxic",
				"Rage",
				"Double-Team",
				"Focus-Energy",
				"Skull-Bash",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Superpower",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Mud-Shot",
				"Payback",
				"Poison-Jab",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Cotton-Guard",
				"Head-Charge",
				"Belch",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Bouffalant PokemonInstance Class
	#region Bouffalant
	public class BouffalantInstance : PokemonInstance
	{
		#region Bouffalant Constructors
		/// <summary>
		/// Bouffalant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BouffalantInstance(string nickname, int level)
		: base(
				626,
				SpeciesBouffalant.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bouffalant Builder only waiting for a Level
		/// </summary>
		public BouffalantInstance(int level)
		: base(
				626,
				SpeciesBouffalant.Instance, // PokemonInstance Species
				"Bouffalant", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bouffalant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bouffalant() : base(
			626,
			SpeciesBouffalant.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}