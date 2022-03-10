using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shuckle Species to store common natural stats of all Shuckles
	#region SpeciesShuckle
	public class SpeciesShuckle : PokemonSpecies
	{
#nullable enable
		private static SpeciesShuckle? _instance = null;
#nullable restore
        public static SpeciesShuckle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShuckle();
                }
                return _instance;
            }
        }

		#region SpeciesShuckle Constructor
		public SpeciesShuckle() : base(
			"Shuckle",
			0.6,
			20.5,
			20, // HPs
			10, 230, // Attack & Defense
			10, 230, // Special Attack & Defense
			5		
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
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Acid",
				"Strength",
				"String-Shot",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Defense-Curl",
				"Bide",
				"Constrict",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Rock-Blast",
				"Gyro-Ball",
				"Natural-Gift",
				"Acupressure",
				"Power-Trick",
				"Gastro-Acid",
				"Rock-Polish",
				"Earth-Power",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Guard-Split",
				"Power-Split",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Shell-Smash",
				"Final-Gambit",
				"Struggle-Bug",
				"Bulldoze",
				"Sticky-Web",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Shuckle PokemonInstance Class
	#region Shuckle
	public class ShuckleInstance : PokemonInstance
	{
		#region Shuckle Constructors
		/// <summary>
		/// Shuckle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShuckleInstance(string nickname, int level)
		: base(
				213,
				SpeciesShuckle.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuckle Builder only waiting for a Level
		/// </summary>
		public ShuckleInstance(int level)
		: base(
				213,
				SpeciesShuckle.Instance, // PokemonInstance Species
				"Shuckle", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuckle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shuckle() : base(
			213,
			SpeciesShuckle.Instance, // PokemonInstance Species
			Bug.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}