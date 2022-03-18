using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Reshiram Species to store common natural stats of all Reshirams
	#region SpeciesReshiram
	public class SpeciesReshiram : PokemonSpecies
	{
#nullable enable
		private static SpeciesReshiram? _instance = null;
#nullable restore
        public static SpeciesReshiram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesReshiram();
                }
                return _instance;
            }
        }

		#region SpeciesReshiram Constructor
		public SpeciesReshiram() : base(
			643,
			"Reshiram",
			3.2,
			330.0,
			100, // HPs
			120, 100, // Attack & Defense
			150, 120, // Special Attack & Defense
			90		
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
				"Cut",
				"Fly",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Dragon-Rage",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Imprison",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Extrasensory",
				"Dragon-Claw",
				"Roost",
				"Tailwind",
				"Payback",
				"Fling",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Stone-Edge",
				"Hone-Claws",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Dragon-Tail",
				"Blue-Flare",
				"Fusion-Flare",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Reshiram PokemonInstance Class
	#region Reshiram
	public class ReshiramInstance : PokemonInstance
	{
		#region Reshiram Constructors
		/// <summary>
		/// Reshiram Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ReshiramInstance(string nickname, int level)
		: base(
				SpeciesReshiram.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reshiram Builder only waiting for a Level
		/// </summary>
		public ReshiramInstance(int level)
		: base(
				SpeciesReshiram.Instance, // PokemonInstance Species
				"Reshiram", level,
				Dragon.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reshiram Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ReshiramInstance() : base(
			SpeciesReshiram.Instance, // PokemonInstance Species
			Dragon.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}