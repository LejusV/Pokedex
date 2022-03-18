using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Marill Species to store common natural stats of all Marills
	#region SpeciesMarill
	public class SpeciesMarill : PokemonSpecies
	{
#nullable enable
		private static SpeciesMarill? _instance = null;
#nullable restore
        public static SpeciesMarill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMarill();
                }
                return _instance;
            }
        }

		#region SpeciesMarill Constructor
		public SpeciesMarill() : base(
			183,
			"Marill",
			0.4,
			8.5,
			70, // HPs
			20, 50, // Attack & Defense
			20, 50, // Special Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Foresight",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Hyper-Voice",
				"Muddy-Water",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Captivate",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Marill PokemonInstance Class
	#region Marill
	public class MarillInstance : PokemonInstance
	{
		#region Marill Constructors
		/// <summary>
		/// Marill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MarillInstance(string nickname, int level)
		: base(
				SpeciesMarill.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marill Builder only waiting for a Level
		/// </summary>
		public MarillInstance(int level)
		: base(
				SpeciesMarill.Instance, // PokemonInstance Species
				"Marill", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marill Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MarillInstance() : base(
			SpeciesMarill.Instance, // PokemonInstance Species
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}