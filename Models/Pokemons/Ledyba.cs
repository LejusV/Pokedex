using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ledyba Species to store common natural stats of all Ledybas
	#region SpeciesLedyba
	public class SpeciesLedyba : PokemonSpecies
	{
#nullable enable
		private static SpeciesLedyba? _instance = null;
#nullable restore
        public static SpeciesLedyba Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLedyba();
                }
                return _instance;
            }
        }

		#region SpeciesLedyba Constructor
		public SpeciesLedyba() : base(
			165,
			"Ledyba",
			1.0,
			10.8,
			40, // HPs
			20, 30, // Attack & Defense
			40, 80, // Special Attack & Defense
			55		
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
				"Psybeam",
				"Counter",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Dizzy-Punch",
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
				"Encore",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
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

	//Ledyba PokemonInstance Class
	#region Ledyba
	public class LedybaInstance : PokemonInstance
	{
		#region Ledyba Constructors
		/// <summary>
		/// Ledyba Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LedybaInstance(string nickname, int level)
		: base(
				SpeciesLedyba.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledyba Builder only waiting for a Level
		/// </summary>
		public LedybaInstance(int level)
		: base(
				SpeciesLedyba.Instance, // PokemonInstance Species
				"Ledyba", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledyba Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LedybaInstance() : base(
			SpeciesLedyba.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}