using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Eelektross Species to store common natural stats of all Eelektrosss
	#region EelektrossSpecies
	public class EelektrossSpecies : PokemonSpecies
	{
#nullable enable
		private static EelektrossSpecies? _instance = null;
#nullable restore
        public static EelektrossSpecies Instance => _instance ?? (_instance = new EelektrossSpecies());

		#region EelektrossSpecies Constructor
		public EelektrossSpecies() : base(
			604,
			"Eelektross",
			Electric.Instance,
			2.1,
			80.5,
			new PokemonStats(
				85, // HPs
				115, 80, // Attack & Defense
				105, 80, // Spacial Attack & Defense
				50 // Speed
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
}