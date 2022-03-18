using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Groudon Species to store common natural stats of all Groudons
	#region SpeciesGroudon
	public class SpeciesGroudon : PokemonSpecies
	{
#nullable enable
		private static SpeciesGroudon? _instance = null;
#nullable restore
        public static SpeciesGroudon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGroudon();
                }
                return _instance;
            }
        }

		#region SpeciesGroudon Constructor
		public SpeciesGroudon() : base(
			383,
			"Groudon",
			3.5,
			950.0,
			100, // HPs
			150, 140, // Attack & Defense
			100, 90, // Special Attack & Defense
			90		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Brick-Break",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Bulk-Up",
				"Mud-Shot",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Rock-Polish",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch",
				"Precipice-Blades",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Groudon PokemonInstance Class
	#region Groudon
	public class GroudonInstance : PokemonInstance
	{
		#region Groudon Constructors
		/// <summary>
		/// Groudon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GroudonInstance(string nickname, int level)
		: base(
				SpeciesGroudon.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Groudon Builder only waiting for a Level
		/// </summary>
		public GroudonInstance(int level)
		: base(
				SpeciesGroudon.Instance, // PokemonInstance Species
				"Groudon", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Groudon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GroudonInstance() : base(
			SpeciesGroudon.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}