using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magmortar Species to store common natural stats of all Magmortars
	#region SpeciesMagmortar
	public class SpeciesMagmortar : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagmortar? _instance = null;
#nullable restore
        public static SpeciesMagmortar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagmortar();
                }
                return _instance;
            }
        }

		#region SpeciesMagmortar Constructor
		public SpeciesMagmortar() : base(
			467,
			"Magmortar",
			1.6,
			68.0,
			75, // HPs
			95, 67, // Attack & Defense
			125, 95, // Special Attack & Defense
			83		
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
				"Thunder-Punch",
				"Headbutt",
				"Leer",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Thunderbolt",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Covet",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Lava-Plume",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Clear-Smog",
				"Incinerate",
				"Bulldoze",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Magmortar PokemonInstance Class
	#region Magmortar
	public class MagmortarInstance : PokemonInstance
	{
		#region Magmortar Constructors
		/// <summary>
		/// Magmortar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagmortarInstance(string nickname, int level)
		: base(
				SpeciesMagmortar.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmortar Builder only waiting for a Level
		/// </summary>
		public MagmortarInstance(int level)
		: base(
				SpeciesMagmortar.Instance, // PokemonInstance Species
				"Magmortar", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmortar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MagmortarInstance() : base(
			SpeciesMagmortar.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}