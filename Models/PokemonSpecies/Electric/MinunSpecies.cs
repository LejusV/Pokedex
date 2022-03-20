using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Minun Species to store common natural stats of all Minuns
	#region MinunSpecies
	public class MinunSpecies : PokemonSpecies
	{
#nullable enable
		private static MinunSpecies? _instance = null;
#nullable restore
        public static MinunSpecies Instance => _instance ?? (_instance = new MinunSpecies());

		#region MinunSpecies Constructor
		public MinunSpecies() : base(
			312,
			"Minun",
			Electric.Instance,
			0.4,
			4.2,
			new PokemonStats(
				60, // HPs
				40, 50, // Attack & Defense
				75, 85, // Spacial Attack & Defense
				95 // Speed
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
				"Mega-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Sing",
				"Counter",
				"Seismic-Toss",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Metronome",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Wish",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Trump-Card",
				"Lucky-Chant",
				"Copycat",
				"Last-Resort",
				"Magnet-Rise",
				"Switcheroo",
				"Nasty-Plot",
				"Discharge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Electro-Ball",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Play-Nice",
				"Confide",
				"Nuzzle",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}