using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pansear Species to store common natural stats of all Pansears
	#region SpeciesPansear
	public class SpeciesPansear : PokemonSpecies
	{
#nullable enable
		private static SpeciesPansear? _instance = null;
#nullable restore
        public static SpeciesPansear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPansear();
                }
                return _instance;
            }
        }

		#region SpeciesPansear Constructor
		public SpeciesPansear() : base(
			513,
			"Pansear",
			0.6,
			11.0,
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
				"Fire-Punch",
				"Scratch",
				"Cut",
				"Leer",
				"Bite",
				"Flamethrower",
				"Low-Kick",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Astonish",
				"Overheat",
				"Rock-Tomb",
				"Tickle",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Flare-Blitz",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Belch",
				"Disarming-Voice",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pansear PokemonInstance Class
	#region Pansear
	public class PansearInstance : PokemonInstance
	{
		#region Pansear Constructors
		/// <summary>
		/// Pansear Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PansearInstance(string nickname, int level)
		: base(
				SpeciesPansear.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansear Builder only waiting for a Level
		/// </summary>
		public PansearInstance(int level)
		: base(
				SpeciesPansear.Instance, // PokemonInstance Species
				"Pansear", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansear Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PansearInstance() : base(
			SpeciesPansear.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}