using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Registeel Species to store common natural stats of all Registeels
	#region SpeciesRegisteel
	public class SpeciesRegisteel : PokemonSpecies
	{
#nullable enable
		private static SpeciesRegisteel? _instance = null;
#nullable restore
        public static SpeciesRegisteel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRegisteel();
                }
                return _instance;
            }
        }

		#region SpeciesRegisteel Constructor
		public SpeciesRegisteel() : base(
			"Registeel",
			1.9,
			205.0,
			80, // HPs
			75, 150, // Attack & Defense
			75, 150, // Special Attack & Defense
			50		
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
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Rock-Polish",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stealth-Rock",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Registeel PokemonInstance Class
	#region Registeel
	public class RegisteelInstance : PokemonInstance
	{
		#region Registeel Constructors
		/// <summary>
		/// Registeel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RegisteelInstance(string nickname, int level)
		: base(
				379,
				SpeciesRegisteel.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Registeel Builder only waiting for a Level
		/// </summary>
		public RegisteelInstance(int level)
		: base(
				379,
				SpeciesRegisteel.Instance, // PokemonInstance Species
				"Registeel", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Registeel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Registeel() : base(
			379,
			SpeciesRegisteel.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}