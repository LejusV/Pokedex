using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Simisear Species to store common natural stats of all Simisears
	#region SpeciesSimisear
	public class SpeciesSimisear : PokemonSpecies
	{
#nullable enable
		private static SpeciesSimisear? _instance = null;
#nullable restore
        public static SpeciesSimisear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSimisear();
                }
                return _instance;
            }
        }

		#region SpeciesSimisear Constructor
		public SpeciesSimisear() : base(
			514,
			"Simisear",
			1.0,
			28.0,
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101		
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
				"Cut",
				"Leer",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
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
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Covet",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Focus-Blast",
				"Giga-Impact",
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
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Simisear PokemonInstance Class
	#region Simisear
	public class SimisearInstance : PokemonInstance
	{
		#region Simisear Constructors
		/// <summary>
		/// Simisear Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SimisearInstance(string nickname, int level)
		: base(
				SpeciesSimisear.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisear Builder only waiting for a Level
		/// </summary>
		public SimisearInstance(int level)
		: base(
				SpeciesSimisear.Instance, // PokemonInstance Species
				"Simisear", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisear Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SimisearInstance() : base(
			SpeciesSimisear.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}