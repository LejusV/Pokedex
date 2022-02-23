using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kecleon Specie to store common natural stats of every {'abilities': ['color-change', 'protean'], 'base_experience': 154, 'height': 10, 'id': 352, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'bind', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'tail-whip', 'disable', 'flamethrower', 'ice-beam', 'blizzard', 'psybeam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'recover', 'defense-curl', 'metronome', 'lick', 'fire-blast', 'swift', 'dizzy-punch', 'flash', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'fake-out', 'facade', 'focus-punch', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'camouflage', 'astonish', 'rock-tomb', 'aerial-ace', 'shock-wave', 'water-pulse', 'natural-gift', 'feint', 'fling', 'last-resort', 'sucker-punch', 'aqua-tail', 'drain-punch', 'nasty-plot', 'shadow-claw', 'shadow-sneak', 'trick-room', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'hone-claws', 'wonder-room', 'synchronoise', 'foul-play', 'after-you', 'round', 'incinerate', 'retaliate', 'work-up', 'confide', 'power-up-punch'], 'name': 'kecleon', 'stats': {'hp': 60, 'attack': 90, 'defense': 70, 'special-attack': 60, 'special-defense': 120, 'speed': 40}, 'types': ['normal'], 'weight': 220, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'green', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'カクレオン', 'roomaji': 'Kakureon', 'ko': '켈리몬', 'zh-Hant': '變隱龍', 'fr': 'Kecleon', 'de': 'Kecleon', 'es': 'Kecleon', 'it': 'Kecleon', 'en': 'Kecleon', 'ja': 'カクレオン', 'zh-Hans': '变隐龙'}, 'genera': {'ja-Hrkt': 'いろへんげポケモン', 'ko': '색변화포켓몬', 'zh-Hant': '變色寶可夢', 'fr': 'Pokémon Multicolor', 'de': 'Farbenspiel', 'es': 'Pokémon Camaleónico', 'it': 'Pokémon Mutacolore', 'en': 'Color Swap Pokémon', 'ja': 'いろへんげポケモン', 'zh-Hans': '变色宝可梦'}}
	public class SpecieKecleon : PokemonSpecie
	{
#nullable enable
		private static SpecieKecleon? _instance = null;
#nullable restore
        public static SpecieKecleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKecleon();
                }
                return _instance;
            }
        }

		public SpecieKecleon() : base(
			"Kecleon",
			60, // HPs
			90, 70, // Attack & Defense
			60, 120, // Special Attack & Defense
			40			
		) {}
	}


	//Kecleon Pokemon Class
	public class Kecleon : Pokemon
	{

		public Kecleon(string nickname, int level) : base(
			352,
			SpecieKecleon.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Kecleon() : base(
			352,
			SpecieKecleon.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}