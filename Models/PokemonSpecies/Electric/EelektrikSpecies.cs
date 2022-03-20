using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Eelektrik Species to store common natural stats of all Eelektriks
	#region EelektrikSpecies
	public class EelektrikSpecies : PokemonSpecies
	{
#nullable enable
		private static EelektrikSpecies? _instance = null;
#nullable restore
        public static EelektrikSpecies Instance => _instance ?? (_instance = new EelektrikSpecies());

		#region EelektrikSpecies Constructor
		public EelektrikSpecies() : base(
			603,
			"Eelektrik",
			Electric.Instance,
			1.2,
			22.0,
			new PokemonStats(
				65, // HPs
				85, 70, // Attack & Defense
				75, 70, // Spacial Attack & Defense
				40 // Speed
			)			
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
				"Bind",
				"Headbutt",
				"Thrash",
				"Acid",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Giga-Drain",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"U-Turn",
				"Gastro-Acid",
				"Magnet-Rise",
				"Aqua-Tail",
				"Flash-Cannon",
				"Discharge",
				"Charge-Beam",
				"Coil",
				"Acid-Spray",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}