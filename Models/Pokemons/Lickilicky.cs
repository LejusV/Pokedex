using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lickilicky Species to store common natural stats of all Lickilickys
	#region SpeciesLickilicky
	public class SpeciesLickilicky : PokemonSpecies
	{
#nullable enable
		private static SpeciesLickilicky? _instance = null;
#nullable restore
        public static SpeciesLickilicky Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLickilicky();
                }
                return _instance;
            }
        }

		#region SpeciesLickilicky Constructor
		public SpeciesLickilicky() : base(
			"Lickilicky",
			1.7,
			140.0,
			110, // HPs
			85, 95, // Attack & Defense
			80, 95, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Bind",
				"Slam",
				"Stomp",
				"Headbutt",
				"Wrap",
				"Supersonic",
				"Disable",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Lick",
				"Fire-Blast",
				"Dream-Eater",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Wring-Out",
				"Me-First",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Power-Whip",
				"Captivate",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Lickilicky PokemonInstance Class
	#region Lickilicky
	public class LickilickyInstance : PokemonInstance
	{
		#region Lickilicky Constructors
		/// <summary>
		/// Lickilicky Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LickilickyInstance(string nickname, int level)
		: base(
				463,
				SpeciesLickilicky.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickilicky Builder only waiting for a Level
		/// </summary>
		public LickilickyInstance(int level)
		: base(
				463,
				SpeciesLickilicky.Instance, // PokemonInstance Species
				"Lickilicky", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickilicky Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lickilicky() : base(
			463,
			SpeciesLickilicky.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}