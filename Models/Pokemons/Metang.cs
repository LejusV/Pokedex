using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Metang Species to store common natural stats of all Metangs
	#region SpeciesMetang
	public class SpeciesMetang : PokemonSpecies
	{
#nullable enable
		private static SpeciesMetang? _instance = null;
#nullable restore
        public static SpeciesMetang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMetang();
                }
                return _instance;
            }
        }

		#region SpeciesMetang Constructor
		public SpeciesMetang() : base(
			375,
			"Metang",
			1.2,
			202.5,
			60, // HPs
			75, 100, // Attack & Defense
			55, 80, // Special Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Swift",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Trick",
				"Brick-Break",
				"Secret-Power",
				"Meteor-Mash",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Gravity",
				"Miracle-Eye",
				"Gyro-Ball",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Bullet-Punch",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Metang PokemonInstance Class
	#region Metang
	public class MetangInstance : PokemonInstance
	{
		#region Metang Constructors
		/// <summary>
		/// Metang Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MetangInstance(string nickname, int level)
		: base(
				SpeciesMetang.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metang Builder only waiting for a Level
		/// </summary>
		public MetangInstance(int level)
		: base(
				SpeciesMetang.Instance, // PokemonInstance Species
				"Metang", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metang Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MetangInstance() : base(
			SpeciesMetang.Instance, // PokemonInstance Species
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}