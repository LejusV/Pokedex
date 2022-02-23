using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cacturne Specie to store common natural stats of every {'abilities': ['sand-veil', 'water-absorb'], 'base_experience': 166, 'height': 13, 'id': 332, 'moves': ['mega-punch', 'thunder-punch', 'swords-dance', 'cut', 'mega-kick', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'poison-sting', 'pin-missile', 'leer', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'absorb', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'mimic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'cotton-spore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'spikes', 'destiny-bond', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'focus-punch', 'nature-power', 'role-play', 'ingrain', 'superpower', 'revenge', 'brick-break', 'secret-power', 'needle-arm', 'bullet-seed', 'block', 'natural-gift', 'payback', 'embargo', 'fling', 'worry-seed', 'sucker-punch', 'poison-jab', 'dark-pulse', 'seed-bomb', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'captivate', 'grass-knot', 'venoshock', 'foul-play', 'round', 'retaliate', 'confide', 'spiky-shield', 'power-up-punch'], 'name': 'cacturne', 'stats': {'hp': 70, 'attack': 115, 'defense': 60, 'special-attack': 115, 'special-defense': 60, 'speed': 55}, 'types': ['grass', 'dark'], 'weight': 774, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'green', 'shape': 'humanoid', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant', 'humanshape'], 'names': {'ja-Hrkt': 'ノクタス', 'roomaji': 'Noctus', 'ko': '밤선인', 'zh-Hant': '夢歌仙人掌', 'fr': 'Cacturne', 'de': 'Noktuska', 'es': 'Cacturne', 'it': 'Cacturne', 'en': 'Cacturne', 'ja': 'ノクタス', 'zh-Hans': '梦歌仙人掌'}, 'genera': {'ja-Hrkt': 'カカシぐさポケモン', 'ko': '허수아비포켓몬', 'zh-Hant': '稻草人寶可夢', 'fr': 'Pokémon Épouvantail', 'de': 'Vogelschock', 'es': 'Pokémon Espantajo', 'it': 'Pokémon Spavento', 'en': 'Scarecrow Pokémon', 'ja': 'カカシぐさポケモン', 'zh-Hans': '稻草人宝可梦'}}
	public class SpecieCacturne : PokemonSpecie
	{
#nullable enable
		private static SpecieCacturne? _instance = null;
#nullable restore
        public static SpecieCacturne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCacturne();
                }
                return _instance;
            }
        }

		public SpecieCacturne() : base(
			"Cacturne",
			70, // HPs
			115, 60, // Attack & Defense
			115, 60, // Special Attack & Defense
			55			
		) {}
	}


	//Cacturne Pokemon Class
	public class Cacturne : Pokemon
	{

		public Cacturne(string nickname, int level) : base(
			332,
			SpecieCacturne.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Dark.Instance			
		) {}

		public Cacturne() : base(
			332,
			SpecieCacturne.Instance, // Pokemon Specie
			Grass.Instance, Dark.Instance			
		) {}
	}
}