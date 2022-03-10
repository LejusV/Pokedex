using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gulpin Species to store common natural stats of all Gulpins
	#region SpeciesGulpin
	public class SpeciesGulpin : PokemonSpecies
	{
#nullable enable
		private static SpeciesGulpin? _instance = null;
#nullable restore
        public static SpeciesGulpin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGulpin();
                }
                return _instance;
            }
        }

		#region SpeciesGulpin Constructor
		public SpeciesGulpin() : base(
			"Gulpin",
			0.4,
			10.3,
			70, // HPs
			43, 53, // Attack & Defense
			43, 53, // Special Attack & Defense
			40		
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Smog",
				"Sludge",
				"Amnesia",
				"Dream-Eater",
				"Poison-Gas",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Destiny-Bond",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Bullet-Seed",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Seed-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Gulpin PokemonInstance Class
	#region Gulpin
	public class GulpinInstance : PokemonInstance
	{
		#region Gulpin Constructors
		/// <summary>
		/// Gulpin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GulpinInstance(string nickname, int level)
		: base(
				316,
				SpeciesGulpin.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gulpin Builder only waiting for a Level
		/// </summary>
		public GulpinInstance(int level)
		: base(
				316,
				SpeciesGulpin.Instance, // PokemonInstance Species
				"Gulpin", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gulpin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Gulpin() : base(
			316,
			SpeciesGulpin.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}