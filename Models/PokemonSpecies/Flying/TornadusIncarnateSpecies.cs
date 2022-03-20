using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tornadus-Incarnate Species to store common natural stats of all Tornadus-Incarnates
	#region Tornadus-IncarnateSpecies
	public class TornadusIncarnateSpecies : PokemonSpecies
	{
#nullable enable
		private static TornadusIncarnateSpecies? _instance = null;
#nullable restore
        public static TornadusIncarnateSpecies Instance => _instance ?? (_instance = new TornadusIncarnateSpecies());

		#region Tornadus-IncarnateSpecies Constructor
		public TornadusIncarnateSpecies() : base(
			641,
			"Tornadus-Incarnate",
			Flying.Instance,
			1.5,
			63.0,
			new PokemonStats(
				79, // HPs
				115, 70, // Attack & Defense
				125, 80, // Spacial Attack & Defense
				111 // Speed
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
				"Gust",
				"Fly",
				"Thrash",
				"Bite",
				"Hyper-Beam",
				"Strength",
				"Toxic",
				"Psychic",
				"Agility",
				"Double-Team",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
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
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Astonish",
				"Air-Cutter",
				"Extrasensory",
				"Aerial-Ace",
				"Bulk-Up",
				"Hammer-Arm",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Air-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Grass-Knot",
				"Smack-Down",
				"Sludge-Wave",
				"Foul-Play",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Acrobatics",
				"Hurricane",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}