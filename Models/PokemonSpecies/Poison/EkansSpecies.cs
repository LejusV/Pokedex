using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ekans Species to store common natural stats of all Ekanss
	#region EkansSpecies
	public class EkansSpecies : PokemonSpecies
	{
#nullable enable
		private static EkansSpecies? _instance = null;
#nullable restore
        public static EkansSpecies Instance => _instance ?? (_instance = new EkansSpecies());

		#region EkansSpecies Constructor
		public EkansSpecies() : base(
			23,
			"Ekans",
			Poison.Instance,
			2.0,
			6.9,
			new PokemonStats(
				35, // HPs
				60, 44, // Attack & Defense
				40, 54, // Spacial Attack & Defense
				55 // Speed
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
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Leer",
				"Bite",
				"Disable",
				"Acid",
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
				"Scary-Face",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Beat-Up",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Facade",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Rock-Tomb",
				"Poison-Tail",
				"Natural-Gift",
				"Payback",
				"Gastro-Acid",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Aqua-Tail",
				"Seed-Bomb",
				"Switcheroo",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Coil",
				"Acid-Spray",
				"Round",
				"Bulldoze",
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