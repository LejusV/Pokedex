using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Eelektross Species to store common natural stats of all Eelektrosss
	#region SpeciesEelektross
	public class SpeciesEelektross : PokemonSpecies
	{
#nullable enable
		private static SpeciesEelektross? _instance = null;
#nullable restore
        public static SpeciesEelektross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEelektross();
                }
                return _instance;
            }
        }

		#region SpeciesEelektross Constructor
		public SpeciesEelektross() : base(
			604,
			"Eelektross",
			2.1,
			80.5,
			85, // HPs
			115, 80, // Attack & Defense
			105, 80, // Special Attack & Defense
			50		
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
				"Cut",
				"Bind",
				"Headbutt",
				"Thrash",
				"Roar",
				"Acid",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Outrage",
				"Giga-Drain",
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
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Signal-Beam",
				"Dragon-Claw",
				"Bounce",
				"Shock-Wave",
				"U-Turn",
				"Gastro-Acid",
				"Magnet-Rise",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Drain-Punch",
				"Giga-Impact",
				"Flash-Cannon",
				"Discharge",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Coil",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Dragon-Tail",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Eelektross PokemonInstance Class
	#region Eelektross
	public class EelektrossInstance : PokemonInstance
	{
		#region Eelektross Constructors
		/// <summary>
		/// Eelektross Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EelektrossInstance(string nickname, int level)
		: base(
				SpeciesEelektross.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektross Builder only waiting for a Level
		/// </summary>
		public EelektrossInstance(int level)
		: base(
				SpeciesEelektross.Instance, // PokemonInstance Species
				"Eelektross", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektross Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EelektrossInstance() : base(
			SpeciesEelektross.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}