using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Farfetchd Species to store common natural stats of all Farfetchds
	#region SpeciesFarfetchd
	public class SpeciesFarfetchd : PokemonSpecies
	{
#nullable enable
		private static SpeciesFarfetchd? _instance = null;
#nullable restore
        public static SpeciesFarfetchd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFarfetchd();
                }
                return _instance;
            }
        }

		#region SpeciesFarfetchd Constructor
		public SpeciesFarfetchd() : base(
			"Farfetchd",
			0.8,
			15.0,
			52, // HPs
			90, 55, // Attack & Defense
			58, 62, // Special Attack & Defense
			60		
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Gust",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Headbutt",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Skull-Bash",
				"Sky-Attack",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Helping-Hand",
				"Revenge",
				"Knock-Off",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Covet",
				"Leaf-Blade",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Trump-Card",
				"Last-Resort",
				"Poison-Jab",
				"Night-Slash",
				"Air-Slash",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Simple-Beam",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide",
				"First-Impression",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Farfetchd PokemonInstance Class
	#region Farfetchd
	public class FarfetchdInstance : PokemonInstance
	{
		#region Farfetchd Constructors
		/// <summary>
		/// Farfetchd Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FarfetchdInstance(string nickname, int level)
		: base(
				83,
				SpeciesFarfetchd.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Farfetchd Builder only waiting for a Level
		/// </summary>
		public FarfetchdInstance(int level)
		: base(
				83,
				SpeciesFarfetchd.Instance, // PokemonInstance Species
				"Farfetchd", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Farfetchd Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Farfetchd() : base(
			83,
			SpeciesFarfetchd.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}