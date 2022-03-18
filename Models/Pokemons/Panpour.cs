using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Panpour Species to store common natural stats of all Panpours
	#region SpeciesPanpour
	public class SpeciesPanpour : PokemonSpecies
	{
#nullable enable
		private static SpeciesPanpour? _instance = null;
#nullable restore
        public static SpeciesPanpour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPanpour();
                }
                return _instance;
            }
        }

		#region SpeciesPanpour Constructor
		public SpeciesPanpour() : base(
			515,
			"Panpour",
			0.6,
			13.5,
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64		
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
				"Ice-Punch",
				"Scratch",
				"Cut",
				"Leer",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Waterfall",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Recycle",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Astonish",
				"Rock-Tomb",
				"Tickle",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Aqua-Ring",
				"Aqua-Tail",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Panpour PokemonInstance Class
	#region Panpour
	public class PanpourInstance : PokemonInstance
	{
		#region Panpour Constructors
		/// <summary>
		/// Panpour Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PanpourInstance(string nickname, int level)
		: base(
				SpeciesPanpour.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Panpour Builder only waiting for a Level
		/// </summary>
		public PanpourInstance(int level)
		: base(
				SpeciesPanpour.Instance, // PokemonInstance Species
				"Panpour", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Panpour Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PanpourInstance() : base(
			SpeciesPanpour.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}