using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Simipour Species to store common natural stats of all Simipours
	#region SpeciesSimipour
	public class SpeciesSimipour : PokemonSpecies
	{
#nullable enable
		private static SpeciesSimipour? _instance = null;
#nullable restore
        public static SpeciesSimipour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSimipour();
                }
                return _instance;
            }
        }

		#region SpeciesSimipour Constructor
		public SpeciesSimipour() : base(
			516,
			"Simipour",
			1.0,
			29.0,
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
				"Ice-Punch",
				"Cut",
				"Leer",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Waterfall",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
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
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Torment",
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
				"Dive",
				"Rock-Tomb",
				"Covet",
				"Water-Pulse",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
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
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Simipour PokemonInstance Class
	#region Simipour
	public class SimipourInstance : PokemonInstance
	{
		#region Simipour Constructors
		/// <summary>
		/// Simipour Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SimipourInstance(string nickname, int level)
		: base(
				SpeciesSimipour.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simipour Builder only waiting for a Level
		/// </summary>
		public SimipourInstance(int level)
		: base(
				SpeciesSimipour.Instance, // PokemonInstance Species
				"Simipour", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simipour Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SimipourInstance() : base(
			SpeciesSimipour.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}