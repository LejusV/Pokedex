using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Electivire Species to store common natural stats of all Electivires
	#region SpeciesElectivire
	public class SpeciesElectivire : PokemonSpecies
	{
#nullable enable
		private static SpeciesElectivire? _instance = null;
#nullable restore
        public static SpeciesElectivire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesElectivire();
                }
                return _instance;
            }
        }

		#region SpeciesElectivire Constructor
		public SpeciesElectivire() : base(
			"Electivire",
			1.8,
			138.6,
			75, // HPs
			123, 67, // Attack & Defense
			95, 85, // Special Attack & Defense
			95		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Leer",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Low-Sweep",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Electroweb",
				"Wild-Charge",
				"Dual-Chop",
				"Ion-Deluge",
				"Confide",
				"Electric-Terrain",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Electivire PokemonInstance Class
	#region Electivire
	public class ElectivireInstance : PokemonInstance
	{
		#region Electivire Constructors
		/// <summary>
		/// Electivire Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ElectivireInstance(string nickname, int level)
		: base(
				466,
				SpeciesElectivire.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electivire Builder only waiting for a Level
		/// </summary>
		public ElectivireInstance(int level)
		: base(
				466,
				SpeciesElectivire.Instance, // PokemonInstance Species
				"Electivire", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electivire Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Electivire() : base(
			466,
			SpeciesElectivire.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}