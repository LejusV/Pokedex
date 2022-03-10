using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Combusken Species to store common natural stats of all Combuskens
	#region SpeciesCombusken
	public class SpeciesCombusken : PokemonSpecies
	{
#nullable enable
		private static SpeciesCombusken? _instance = null;
#nullable restore
        public static SpeciesCombusken Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCombusken();
                }
                return _instance;
            }
        }

		#region SpeciesCombusken Constructor
		public SpeciesCombusken() : base(
			"Combusken",
			0.9,
			19.5,
			60, // HPs
			85, 60, // Attack & Defense
			85, 60, // Special Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Ember",
				"Flamethrower",
				"Peck",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Mirror-Move",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Combusken PokemonInstance Class
	#region Combusken
	public class CombuskenInstance : PokemonInstance
	{
		#region Combusken Constructors
		/// <summary>
		/// Combusken Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CombuskenInstance(string nickname, int level)
		: base(
				256,
				SpeciesCombusken.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combusken Builder only waiting for a Level
		/// </summary>
		public CombuskenInstance(int level)
		: base(
				256,
				SpeciesCombusken.Instance, // PokemonInstance Species
				"Combusken", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combusken Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Combusken() : base(
			256,
			SpeciesCombusken.Instance, // PokemonInstance Species
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}