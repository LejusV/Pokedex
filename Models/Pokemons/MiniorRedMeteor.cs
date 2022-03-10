using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Minior-Red-Meteor Species to store common natural stats of all Minior-Red-Meteors
	#region SpeciesMinior-Red-Meteor
	public class SpeciesMiniorRedMeteor : PokemonSpecies
	{
#nullable enable
		private static SpeciesMiniorRedMeteor? _instance = null;
#nullable restore
        public static SpeciesMiniorRedMeteor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMiniorRedMeteor();
                }
                return _instance;
            }
        }

		#region SpeciesMinior-Red-Meteor Constructor
		public SpeciesMiniorRedMeteor() : base(
			"Minior-Red-Meteor",
			0.3,
			40.0,
			60, // HPs
			60, 100, // Attack & Defense
			60, 100, // Special Attack & Defense
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Swift",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Psych-Up",
				"Ancient-Power",
				"Facade",
				"Rock-Tomb",
				"Cosmic-Power",
				"Calm-Mind",
				"Gyro-Ball",
				"U-Turn",
				"Rock-Polish",
				"Power-Gem",
				"Giga-Impact",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Autotomize",
				"Round",
				"Shell-Smash",
				"Acrobatics",
				"Bulldoze",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Minior-Red-Meteor PokemonInstance Class
	#region Minior-Red-Meteor
	public class MiniorRedMeteorInstance : PokemonInstance
	{
		#region Minior-Red-Meteor Constructors
		/// <summary>
		/// Minior-Red-Meteor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MiniorRedMeteorInstance(string nickname, int level)
		: base(
				774,
				SpeciesMiniorRedMeteor.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minior-Red-Meteor Builder only waiting for a Level
		/// </summary>
		public MiniorRedMeteorInstance(int level)
		: base(
				774,
				SpeciesMiniorRedMeteor.Instance, // PokemonInstance Species
				"Minior-Red-Meteor", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minior-Red-Meteor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MiniorRedMeteor() : base(
			774,
			SpeciesMiniorRedMeteor.Instance, // PokemonInstance Species
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}