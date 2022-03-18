using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bonsly Species to store common natural stats of all Bonslys
	#region SpeciesBonsly
	public class SpeciesBonsly : PokemonSpecies
	{
#nullable enable
		private static SpeciesBonsly? _instance = null;
#nullable restore
        public static SpeciesBonsly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBonsly();
                }
                return _instance;
            }
        }

		#region SpeciesBonsly Constructor
		public SpeciesBonsly() : base(
			438,
			"Bonsly",
			0.5,
			15.0,
			50, // HPs
			80, 95, // Attack & Defense
			10, 45, // Special Attack & Defense
			10		
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
				"Slam",
				"Headbutt",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Rock-Throw",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Fake-Tears",
				"Rock-Tomb",
				"Sand-Tomb",
				"Block",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Copycat",
				"Sucker-Punch",
				"Rock-Polish",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Foul-Play",
				"After-You",
				"Round",
				"Confide",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Bonsly PokemonInstance Class
	#region Bonsly
	public class BonslyInstance : PokemonInstance
	{
		#region Bonsly Constructors
		/// <summary>
		/// Bonsly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BonslyInstance(string nickname, int level)
		: base(
				SpeciesBonsly.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bonsly Builder only waiting for a Level
		/// </summary>
		public BonslyInstance(int level)
		: base(
				SpeciesBonsly.Instance, // PokemonInstance Species
				"Bonsly", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bonsly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BonslyInstance() : base(
			SpeciesBonsly.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}