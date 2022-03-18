using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Delcatty Species to store common natural stats of all Delcattys
	#region SpeciesDelcatty
	public class SpeciesDelcatty : PokemonSpecies
	{
#nullable enable
		private static SpeciesDelcatty? _instance = null;
#nullable restore
        public static SpeciesDelcatty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDelcatty();
                }
                return _instance;
            }
        }

		#region SpeciesDelcatty Constructor
		public SpeciesDelcatty() : base(
			301,
			"Delcatty",
			1.1,
			32.6,
			70, // HPs
			65, 65, // Attack & Defense
			55, 55, // Special Attack & Defense
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
				"Double-Slap",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Sing",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Last-Resort",
				"Sucker-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Delcatty PokemonInstance Class
	#region Delcatty
	public class DelcattyInstance : PokemonInstance
	{
		#region Delcatty Constructors
		/// <summary>
		/// Delcatty Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DelcattyInstance(string nickname, int level)
		: base(
				SpeciesDelcatty.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delcatty Builder only waiting for a Level
		/// </summary>
		public DelcattyInstance(int level)
		: base(
				SpeciesDelcatty.Instance, // PokemonInstance Species
				"Delcatty", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delcatty Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DelcattyInstance() : base(
			SpeciesDelcatty.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}