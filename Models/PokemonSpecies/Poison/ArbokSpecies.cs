using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Arbok Species to store common natural stats of all Arboks
	#region ArbokSpecies
	public class ArbokSpecies : PokemonSpecies
	{
#nullable enable
		private static ArbokSpecies? _instance = null;
#nullable restore
        public static ArbokSpecies Instance => _instance ?? (_instance = new ArbokSpecies());

		#region ArbokSpecies Constructor
		public ArbokSpecies() : base(
			24,
			"Arbok",
			Poison.Instance,
			3.5,
			65.0,
			new PokemonStats(
				60, // HPs
				95, 69, // Attack & Defense
				65, 79, // Spacial Attack & Defense
				80 // Speed
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
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Leer",
				"Bite",
				"Acid",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Haze",
				"Bide",
				"Skull-Bash",
				"Glare",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Facade",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Natural-Gift",
				"Payback",
				"Gastro-Acid",
				"Poison-Jab",
				"Dark-Pulse",
				"Aqua-Tail",
				"Seed-Bomb",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Coil",
				"Acid-Spray",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Belch",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}