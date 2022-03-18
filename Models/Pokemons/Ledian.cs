using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ledian Species to store common natural stats of all Ledians
	#region SpeciesLedian
	public class SpeciesLedian : PokemonSpecies
	{
#nullable enable
		private static SpeciesLedian? _instance = null;
#nullable restore
        public static SpeciesLedian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLedian();
                }
                return _instance;
            }
        }

		#region SpeciesLedian Constructor
		public SpeciesLedian() : base(
			166,
			"Ledian",
			1.4,
			35.6,
			55, // HPs
			35, 50, // Attack & Defense
			55, 110, // Special Attack & Defense
			85		
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
				"Comet-Punch",
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Supersonic",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Air-Slash",
				"Bug-Buzz",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Ledian PokemonInstance Class
	#region Ledian
	public class LedianInstance : PokemonInstance
	{
		#region Ledian Constructors
		/// <summary>
		/// Ledian Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LedianInstance(string nickname, int level)
		: base(
				SpeciesLedian.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledian Builder only waiting for a Level
		/// </summary>
		public LedianInstance(int level)
		: base(
				SpeciesLedian.Instance, // PokemonInstance Species
				"Ledian", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledian Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LedianInstance() : base(
			SpeciesLedian.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}