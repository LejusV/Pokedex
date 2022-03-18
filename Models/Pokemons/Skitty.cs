using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skitty Species to store common natural stats of all Skittys
	#region SpeciesSkitty
	public class SpeciesSkitty : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkitty? _instance = null;
#nullable restore
        public static SpeciesSkitty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkitty();
                }
                return _instance;
            }
        }

		#region SpeciesSkitty Constructor
		public SpeciesSkitty() : base(
			300,
			"Skitty",
			0.6,
			11.0,
			50, // HPs
			45, 45, // Attack & Defense
			35, 35, // Special Attack & Defense
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
				"Double-Slap",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Ice-Beam",
				"Blizzard",
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
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Assist",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Cosmic-Power",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Copycat",
				"Last-Resort",
				"Sucker-Punch",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Simple-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Disarming-Voice",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Skitty PokemonInstance Class
	#region Skitty
	public class SkittyInstance : PokemonInstance
	{
		#region Skitty Constructors
		/// <summary>
		/// Skitty Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkittyInstance(string nickname, int level)
		: base(
				SpeciesSkitty.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skitty Builder only waiting for a Level
		/// </summary>
		public SkittyInstance(int level)
		: base(
				SpeciesSkitty.Instance, // PokemonInstance Species
				"Skitty", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skitty Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SkittyInstance() : base(
			SpeciesSkitty.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}