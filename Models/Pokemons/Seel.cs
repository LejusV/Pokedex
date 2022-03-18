using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Seel Species to store common natural stats of all Seels
	#region SpeciesSeel
	public class SpeciesSeel : PokemonSpecies
	{
#nullable enable
		private static SpeciesSeel? _instance = null;
#nullable restore
        public static SpeciesSeel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSeel();
                }
                return _instance;
            }
        }

		#region SpeciesSeel Constructor
		public SpeciesSeel() : base(
			86,
			"Seel",
			1.1,
			90.0,
			65, // HPs
			45, 55, // Attack & Defense
			45, 70, // Special Attack & Defense
			45		
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
				"Pay-Day",
				"Slam",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Disable",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Peck",
				"Strength",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Lick",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Fake-Out",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Icicle-Spear",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Ice-Shard",
				"Captivate",
				"Aqua-Jet",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Drill-Run",
				"Belch",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Seel PokemonInstance Class
	#region Seel
	public class SeelInstance : PokemonInstance
	{
		#region Seel Constructors
		/// <summary>
		/// Seel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SeelInstance(string nickname, int level)
		: base(
				SpeciesSeel.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seel Builder only waiting for a Level
		/// </summary>
		public SeelInstance(int level)
		: base(
				SpeciesSeel.Instance, // PokemonInstance Species
				"Seel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SeelInstance() : base(
			SpeciesSeel.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}